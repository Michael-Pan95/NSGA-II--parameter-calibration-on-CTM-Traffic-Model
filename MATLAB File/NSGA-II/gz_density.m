function density2=gz_density(density1,input0,flow,flow3)
LL=[0.4 0.4 0.4 0.4 0.4 0.4 0.4 0.4 0.4 0.4 0.4 0.4];%LL����ÿ��Ԫ�����ȣ���λkm��һ��12�����ɸ���ʵ���������
for i=1:12
    if i==1
        density2(1)=density1(1)+(input0-flow(1))/720/LL(i)/3;%���ݽ��������Ԫ��������������Ԫ���ܶȣ����沽��5s    5/3600=1/720  ������1������-����2��������
    elseif i==6
        density2(6)=density1(6)+(flow3(1)-flow(6))/720/LL(i)/2;  %������6������-����7��������
    elseif i==7
        density2(7)=density1(7)+(flow(6)-flow(7))/720/LL(i)/2;
    elseif i==8
        density2(8)=density1(8)+(flow3(2)-flow(8))/720/LL(i)/3;
    elseif i==11
        density2(11)=density1(11)+(flow3(3)-flow(11))/720/LL(i)/3;
    elseif i==12
        density2(12)=density1(12)+(flow(11)-flow(12))/720/LL(i)/2;
    else
        density2(i)=density1(i)+(flow(i-1)-flow(i))/720/LL(i)/3;
    end
end
end
