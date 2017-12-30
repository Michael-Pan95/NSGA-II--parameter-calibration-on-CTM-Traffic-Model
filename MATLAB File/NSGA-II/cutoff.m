function  y=cutoff(x1,x2)%flow=cutoff(pmax,density2)
if x1>=x2
    y=x1-x2;
else
    y=0;
end
end