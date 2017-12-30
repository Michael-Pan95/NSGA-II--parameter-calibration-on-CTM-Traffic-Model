function [flow1,flow2]=gz_enter(density1,density2,enterflow,vf,Qmax,pmax,w,lane1,lane2,enterratio)
s1=min([density1*vf*lane1 Qmax*lane1]);% 当前元胞可发送至下一元胞的车流量
s2=enterflow;% 汇入流量：允许放行的车流量（已乘以匝道控制率）
re=min([w*cutoff(pmax,density2)*lane2 Qmax*lane2]);%下游可接受流量
if s1+s2<=re %供给小于需求：匝道所有车辆都可汇入主线
    flow1=s1;  
    flow2=s1+s2;  %元胞i+1接收的总车流量（输入到主线的车流量）
else%供给大于需求，按比例折减
    flow1=median([s1 re-s2 re*(1-enterratio)]);  %最终元胞i主线上发送的车流量
    flow2=re;   %
end
end