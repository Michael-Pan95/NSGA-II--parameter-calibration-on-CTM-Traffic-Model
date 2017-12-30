function [flow,speed,Density]=gz_compute(density0,input0,exitdensity1,exitratio1,enterflow1,...
    enterratio1,enterflow2,enterratio2,output,vf,pmax,w,Qmax,woff,poff,hours)

endT=hours * 180;
for i=1:endT %����ʱ��6h,����6�㵽12��
    flow_sum=zeros(1,12);
    speed_sum=zeros(1,12);
    density_sum=zeros(1,12);
    countspeed=zeros(1,12);
    for j=1:4 %ÿ������ͳ���ڼ���4�Σ���������20s/4=5s
        [fflow, fflow3, sspeed]=gz_flow(density0,exitdensity1(i),exitratio1(i),enterflow1(i),enterratio1(i),enterflow2(i),enterratio2(i),output(i),vf,pmax,w,Qmax,woff,poff);%���㴫������
        density=gz_density(density0,input0(i),fflow,fflow3);   %input��output���Լ�ʵ�����ݶ���ÿ20s�ɼ�������
        density_sum=density_sum+density0;
        flow_sum=fflow+flow_sum;
        speed_sum=fflow.*sspeed+speed_sum;
        density0=density;
        countspeed=countspeed+sspeed;
    end
    for k=1:12%12��Ԫ��
        density_sum(k)=density_sum(k)/4;%ͳ����4�Σ���ƽ��
        if flow_sum(k)~=0
            speed_sum(k)=speed_sum(k)/flow_sum(k);      %ƽ���ٶȲ���ֱ���ö������ļ���������ƽ����������
            flow_sum(k)=flow_sum(k)/4;
        else
            if countspeed(k)==0
                speed_sum(k)=0;
            else
                speed_sum(k)=vf;
            end
        end
    end
    flow(i,:)=flow_sum; %��������������� ��flow_sum��һ��;flow_sum�ڶ��� ...��
    speed(i,:)=speed_sum;
    Density(i,:)=density_sum;
end
flow=flow';speed=speed';Density=Density'; %������һ���б�ʾÿ�ε����ݣ�����12�б�ʾcell
end
