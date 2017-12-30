function [flow,speed,Density]=gz_compute(density0,input0,exitdensity1,exitratio1,enterflow1,...
    enterratio1,enterflow2,enterratio2,output,vf,pmax,w,Qmax,woff,poff,hours)

endT=hours * 180;
for i=1:endT %仿真时长6h,从早6点到12点
    flow_sum=zeros(1,12);
    speed_sum=zeros(1,12);
    density_sum=zeros(1,12);
    countspeed=zeros(1,12);
    for j=1:4 %每次数据统计内计算4次，仿真周期20s/4=5s
        [fflow, fflow3, sspeed]=gz_flow(density0,exitdensity1(i),exitratio1(i),enterflow1(i),enterratio1(i),enterflow2(i),enterratio2(i),output(i),vf,pmax,w,Qmax,woff,poff);%计算传输流量
        density=gz_density(density0,input0(i),fflow,fflow3);   %input和output，以及实际数据都是每20s采集的数据
        density_sum=density_sum+density0;
        flow_sum=fflow+flow_sum;
        speed_sum=fflow.*sspeed+speed_sum;
        density0=density;
        countspeed=countspeed+sspeed;
    end
    for k=1:12%12个元胞
        density_sum(k)=density_sum(k)/4;%统计了4次，求平均
        if flow_sum(k)~=0
            speed_sum(k)=speed_sum(k)/flow_sum(k);      %平均速度不能直接用多辆车的加总起来求平均，不合理
            flow_sum(k)=flow_sum(k)/4;
        else
            if countspeed(k)==0
                speed_sum(k)=0;
            else
                speed_sum(k)=vf;
            end
        end
    end
    flow(i,:)=flow_sum; %类似于数组的数组 【flow_sum第一次;flow_sum第二次 ...】
    speed(i,:)=speed_sum;
    Density(i,:)=density_sum;
end
flow=flow';speed=speed';Density=Density'; %最终是一个行表示每次的数据，并有12列表示cell
end
