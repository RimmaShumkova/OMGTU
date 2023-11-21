from datetime import date

date1 = date(2002, 5, 12)
date2 = date(2002, 5, 15)
delta = date2 - date1
P = int(input())
sum = 0
if 1 <= delta.days < 60000:
    if 0 <= P:
        if P <= 5000:
            for n in range(0,delta.days+1):
                sum += P
                P += 1
                print(P,sum)
print(sum)
