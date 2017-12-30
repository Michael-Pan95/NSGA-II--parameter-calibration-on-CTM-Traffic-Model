function [f1,f2,speed_return,flow_return,density_return]=PI(x,density0,input0,exitdensity1,exitratio1,enterflow1,enterratio1,enterflow2,enterratio2,output,flow_data,speed_data,hours)
%%��ʱ����Ƶļ��ж� hours ��ʾ���漸Сʱ�����ݣ�
%    ʵ����20����һ�Ρ������磺������Ҫ4��5����棬ֻ���ȡ2*180���4�㿪ʼ�����ݣ�

%%
[flow,speed,density]=gz_compute(density0,input0,exitdensity1,exitratio1,enterflow1,enterratio1,...
    enterflow2,enterratio2,output,x(1),x(2),x(3),x(4),x(5),x(6),hours);


%%
%���Ҫ����compute��������ݽ�����Ӧ����

start_index = hours * 180+1;%��һ������Ŀ�ʼ��
end_index = start_index + hours*180-1;%��һ������Ľ���

Speed_data=speed_data(:,start_index:end_index);
Flow_data=flow_data(:,start_index:end_index);


speed_return=speed;
flow_return =flow;
density_return=density;

% f1=((speed-Speed_data)/Speed_data).^2;
% f2=((flow-Flow_data)/Flow_data).^2;
f1=(speed-Speed_data).^2;
f2=(flow-Flow_data).^2;
end
