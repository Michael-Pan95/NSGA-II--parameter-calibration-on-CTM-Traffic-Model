function speed=gz_speed(flow,density,lane,vf)
if flow==0
    if density==0
        speed=vf;
    else
        speed=0;
    end
else
    speed=flow/density/lane;
end