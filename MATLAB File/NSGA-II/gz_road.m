function flow=gz_road(density1,density2,vf,Qmax,pmax,w,lane1,lane2)%·����·��֮�䴫�� �ӵ�ǰԪ�����뵽��һԪ��������
         x1=density1*vf*lane1;
         x2=w*cutoff(pmax,density2)*lane2;
         flow=min([x1 x2 lane1*Qmax lane2*Qmax]);
end