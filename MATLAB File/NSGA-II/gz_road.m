function flow=gz_road(density1,density2,vf,Qmax,pmax,w,lane1,lane2)%路段与路段之间传播 从当前元胞输入到下一元胞的流量
         x1=density1*vf*lane1;
         x2=w*cutoff(pmax,density2)*lane2;
         flow=min([x1 x2 lane1*Qmax lane2*Qmax]);
end