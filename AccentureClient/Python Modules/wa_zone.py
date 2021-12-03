import cv2 as cv
from sys import argv
from PIL import Image


src = cv.imread(argv[1]) #'/Users/nsamoilove/Public/VSC/hackaton_final_2021/Python Modules/Photo/zerno.jpg'
gr = cv.cvtColor(src, cv.COLOR_BGR2GRAY)

bl = cv.medianBlur(gr, 5)

canny = cv.Canny(bl, 10, 250)
kernel = cv.getStructuringElement(cv.MORPH_RECT, (7, 7))
closed = cv.morphologyEx(canny, cv.MORPH_CLOSE, kernel)

contours = cv.findContours(closed.copy(), cv.RETR_EXTERNAL, cv.CHAIN_APPROX_SIMPLE)[0]

for cont in contours:
        sm = cv.arcLength(cont, True)
        apd = cv.approxPolyDP(cont, 0.02*sm, True)
        if len(apd) == 4:
            cv.drawContours(src, [apd], -1, (0,255,0), 4)
            lists = list(apd)

def cropping(src,min_y,max_y,min_x,max_x):
    crop_img = src[min_y:max_y, min_x:max_x]
    return crop_img
    
    
u1,u2,u3,u4 = str(lists[0]),str(lists[1]),str(lists[2]),str(lists[3])
u1,u2,u3,u4 = u1.replace('[',''),u2.replace('[',''),u3.replace('[',''),u4.replace('[','')
u1,u2,u3,u4 = u1.replace(']','').split(' '),u2.replace(']','').split(' '),u3.replace(']','').split(' '),u4.replace(']','').split(' ')
lt_x = list()
lt_y = list()
lt_x.append(u1[0])
lt_y.append(u1[1])
lt_x.append(u2[0])
lt_y.append(u2[1]) 
lt_x.append(u3[0])
lt_y.append(u3[1])
lt_x.append(u4[0])
lt_y.append(u4[1])
#print(lt_x, lt_y)
max_x,max_y,min_x,min_y = 0,0,0,0
max_x = int(max(lt_x))-45
max_y = int(max(lt_y))-35
min_x = int(min(lt_x))+35
min_y = int(min(lt_y))+35
#print(max_x,max_y)
#print(min_x,min_y)

src_top = cropping(src,min_y,max_y,min_x,max_x)

cv.imwrite(argv[2], src_top)



