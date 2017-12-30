function [f1,f2,speed_return,flow_return,density_return]=PI(x,density0,input0,exitdensity1,exitratio1,enterflow1,enterratio1,enterflow2,enterratio2,output,flow_data,speed_data,hours)
%%对时间控制的简单判断 hours 表示仿真几小时的数据，
%    实际中20秒检测一次。（例如：我们需要4：5点仿真，只需抽取2*180组从4点开始的数据）

%%
[flow,speed,density]=gz_compute(density0,input0,exitdensity1,exitratio1,enterflow1,enterratio1,...
    enterflow2,enterratio2,output,x(1),x(2),x(3),x(4),x(5),x(6),hours);


%%
%这个要根据compute里面的数据进行相应更改

start_index = hours * 180+1;%后一半数组的开始；
end_index = start_index + hours*180-1;%后一半数组的结束

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
