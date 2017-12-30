function [flow1,flow2]=gz_enter(density1,density2,enterflow,vf,Qmax,pmax,w,lane1,lane2,enterratio)
s1=min([density1*vf*lane1 Qmax*lane1]);% ��ǰԪ���ɷ�������һԪ���ĳ�����
s2=enterflow;% ����������������еĳ��������ѳ����ѵ������ʣ�
re=min([w*cutoff(pmax,density2)*lane2 Qmax*lane2]);%���οɽ�������
if s1+s2<=re %����С�������ѵ����г������ɻ�������
    flow1=s1;  
    flow2=s1+s2;  %Ԫ��i+1���յ��ܳ����������뵽���ߵĳ�������
else%�����������󣬰������ۼ�
    flow1=median([s1 re-s2 re*(1-enterratio)]);  %����Ԫ��i�����Ϸ��͵ĳ�����
    flow2=re;   %
end
end