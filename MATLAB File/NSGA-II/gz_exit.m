function [flow1,flow2]=gz_exit(density1,density2,exitdensity,vf,Qmax,pmax,w,woff,poff,lane1,lane2,exitratio)
x1=min([density1*vf*lane1 lane1*Qmax]);%��Ԫ�����������
if exitratio==0
    x2=min([w*cutoff(pmax,density2)*lane2 lane2*Qmax]);
    flow1=min([x1 x2]);flow2=flow1;
elseif exitratio==1
    x3=min([woff*cutoff(poff,exitdensity)*2 Qmax*2]);
    flow1=min([x1 x3]);flow2=0;
else
    x2=min([w*cutoff(pmax,density2)*lane2 lane2*Qmax])/(1-exitratio);%�¸�Ԫ���Ľ�������
    x3=min([woff*cutoff(poff,exitdensity)*2 Qmax*2])/exitratio;%�ѵ��Ľ�������
    flow1=min([x1 x2 x3]); %���մ�Ԫ��i������i+1���ܳ����������������ߺ��ѵ��ģ�
    flow2=flow1*(1-exitratio);%�������뵽���ߵĳ�������ʣ����ڳ����ѵ�
end
end