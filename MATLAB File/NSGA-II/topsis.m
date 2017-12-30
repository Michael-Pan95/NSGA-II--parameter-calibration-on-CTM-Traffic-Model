function best_para= topsis(chromosome,V)
%染色体的7，8列为f1,f2，适应度，而topsis是根据这两个数值进行计算，选出最优的
%核心思想： 求和-权重 * (实际值-理想值）^0.5 
%其中权重为变异系数/总变异系数
%其中变异系数为： 标准差/均值

%目标函数值所在列
f1_No = V+1;
f2_No = V+2;
%目标函数值
f1=chromosome(:,f1_No);
f2=chromosome(:,f2_No);
%标准化数据
f1= (f1-min(f1))/(max(f1)-min(f1));
f2= (f2-min(f2))/(max(f2)-min(f2));
%目标均值
mean_f1 = mean(f1);
mean_f2 = mean(f2);
%目标标准差
std_f1 = std(f1);
std_f2 = std(f2);
%目标变异系数
cv_f1 =std_f1/mean_f1;
cv_f2 = std_f2/mean_f2;
%目标权重
w1 = cv_f1/(cv_f1+cv_f2);
w2 = cv_f2/(cv_f1+cv_f2);
%适应度越小，表现越好
fitness = [];
fitness = sqrt(w1*chromosome(:,f1_No).^2+w2*chromosome(:,f2_No).^2);
[temp, tempindex] = sort(fitness);
best_para= chromosome(tempindex(1),:);

