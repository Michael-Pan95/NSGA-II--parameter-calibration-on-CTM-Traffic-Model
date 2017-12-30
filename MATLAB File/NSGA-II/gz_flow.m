function [flow,flow3,speed]=gz_flow(density,exitdensity1,exitratio1,enterflow1,enterratio1,enterflow2,enterratio2,output,vf,pmax,w,Qmax,woff,poff)
%--第一个元胞--%
flow(1)=gz_road(density(1),density(2),vf,Qmax,pmax,w,3,3);%3：车道数 1与2之间的车流量：输入2的车流量
speed(1)=gz_speed(flow(1),density(1),3,vf);
%--第二个元胞--%
flow(2)=gz_road(density(2),density(3),vf,Qmax,pmax,w,3,3);
speed(2)=gz_speed(flow(2),density(2),3,vf);
%--第三个元胞--%
flow(3)=gz_road(density(3),density(4),vf,Qmax,pmax,w,3,3);
speed(3)=gz_speed(flow(3),density(3),3,vf);
%--第四个元胞--%
flow(4)=gz_road(density(4),density(5),vf,Qmax,pmax,w,3,3);
speed(4)=gz_speed(flow(4),density(4),3,vf);
%--第五个元胞--%
[flow(5) flow3(1)]=gz_exit(density(5),density(6),exitdensity1,vf,Qmax,pmax,w,woff,poff,3,2,exitratio1);
speed(5)=gz_speed(flow(5),density(5),3,vf);
%--第六个元胞--%
flow(6)=gz_road(density(6),density(7),vf,Qmax,pmax,w,2,2);
speed(6)=gz_speed(flow(6),density(6),2,vf);
%--第七个元胞--%
[flow(7) flow3(2)]=gz_enter(density(7),density(8),enterflow1,vf,Qmax,pmax,w,2,3,enterratio1);
speed(7)=gz_speed(flow(7),density(7),2,vf);
%--第八个元胞--%
flow(8)=gz_road(density(8),density(9),vf,Qmax,pmax,w,3,3);
speed(8)=gz_speed(flow(8),density(8),3,vf);
%--第九个元胞--%
flow(9)=gz_road(density(9),density(10),vf,Qmax,pmax,w,3,3);
speed(9)=gz_speed(flow(9),density(9),3,vf);
%--第十个元胞--%
[flow(10) flow3(3)]=gz_enter(density(10),density(11),enterflow2,vf,Qmax,pmax,w,3,3,enterratio2);
speed(10)=gz_speed(flow(10),density(10),3,vf);
%--第十一个元胞--%
flow(11)=gz_road(density(11),density(12),vf,Qmax,pmax,w,3,2);
speed(11)=gz_speed(flow(11),density(11),3,vf);
%--第十二个元胞--%
flow(12)=gz_road(density(12),output,vf,Qmax,pmax,w,2,2);
speed(12)=gz_speed(flow(12),density(12),2,vf);
end