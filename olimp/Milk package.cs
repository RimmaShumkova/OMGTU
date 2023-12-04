k = int(input()) 
res = [] 
for i in range(0,k): 
    package = [float(a) for a in input().split()] 
 
    s1 = 2 * ((package[0] * package[1]) + (package[1] * package[2]) + (package[2] * package[0]))   
    s2 = 2 * ((package[3] * package[4]) + (package[4] * package[5]) + (package[3] * package[5])) 
    v1 = package[0] * package[1] * package[2] / 1000 
    v2 = package[3] * package[4] * package[5] / 1000  
    price1 = package[6]  
    price2 = package[7] 
 
    milk = (price1 * s2 - price2 * s1) / (v1 * s2 - v2 * s1)  
    result.append(round(milk,2)) 
 
factor = res.index(min(res)) + 1  
min_price = format(min(res), '.2f')  
print(factor,min_price) 
