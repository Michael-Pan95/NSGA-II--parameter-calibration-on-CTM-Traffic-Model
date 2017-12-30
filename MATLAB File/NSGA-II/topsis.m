function best_para= topsis(chromosome,V)
%Ⱦɫ���7��8��Ϊf1,f2����Ӧ�ȣ���topsis�Ǹ�����������ֵ���м��㣬ѡ�����ŵ�
%����˼�룺 ���-Ȩ�� * (ʵ��ֵ-����ֵ��^0.5 
%����Ȩ��Ϊ����ϵ��/�ܱ���ϵ��
%���б���ϵ��Ϊ�� ��׼��/��ֵ

%Ŀ�꺯��ֵ������
f1_No = V+1;
f2_No = V+2;
%Ŀ�꺯��ֵ
f1=chromosome(:,f1_No);
f2=chromosome(:,f2_No);
%��׼������
f1= (f1-min(f1))/(max(f1)-min(f1));
f2= (f2-min(f2))/(max(f2)-min(f2));
%Ŀ���ֵ
mean_f1 = mean(f1);
mean_f2 = mean(f2);
%Ŀ���׼��
std_f1 = std(f1);
std_f2 = std(f2);
%Ŀ�����ϵ��
cv_f1 =std_f1/mean_f1;
cv_f2 = std_f2/mean_f2;
%Ŀ��Ȩ��
w1 = cv_f1/(cv_f1+cv_f2);
w2 = cv_f2/(cv_f1+cv_f2);
%��Ӧ��ԽС������Խ��
fitness = [];
fitness = sqrt(w1*chromosome(:,f1_No).^2+w2*chromosome(:,f2_No).^2);
[temp, tempindex] = sort(fitness);
best_para= chromosome(tempindex(1),:);

