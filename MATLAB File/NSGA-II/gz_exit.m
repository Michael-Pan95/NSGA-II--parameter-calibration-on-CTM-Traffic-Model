function [flow1,flow2]=gz_exit(density1,density2,exitdensity,vf,Qmax,pmax,w,woff,poff,lane1,lane2,exitratio)
x1=min([density1*vf*lane1 lane1*Qmax]);%该元胞的输出流量
if exitratio==0
    x2=min([w*cutoff(pmax,density2)*lane2 lane2*Qmax]);
    flow1=min([x1 x2]);flow2=flow1;
elseif exitratio==1
    x3=min([woff*cutoff(poff,exitdensity)*2 Qmax*2]);
    flow1=min([x1 x3]);flow2=0;
else
    x2=min([w*cutoff(pmax,density2)*lane2 lane2*Qmax])/(1-exitratio);%下个元胞的接收能力
    x3=min([woff*cutoff(poff,exitdensity)*2 Qmax*2])/exitratio;%匝道的接收能力
    flow1=min([x1 x2 x3]); %最终从元胞i发送至i+1的总车流量（包括了主线和匝道的）
    flow2=flow1*(1-exitratio);%最终输入到主线的车流量，剩余的在出口匝道
end
end