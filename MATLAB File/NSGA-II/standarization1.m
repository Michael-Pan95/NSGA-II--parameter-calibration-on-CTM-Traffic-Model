function [data2]=standarization1(data) %z-score ±ê×¼»¯
means=mean2(data(:));
stds=std2(data(:));
    if stds ==0
        data2=inf;
    else
        data2=(data-means)/stds;
    end
end
