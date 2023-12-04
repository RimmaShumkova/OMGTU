massiv1 = input().split(' ')
n1 = int(massiv1[0])
massiv1.pop(0)

for i in range(len(massiv1)):
    massiv1[i] = int(massiv1[i])
    l1 = input().split(' ')

for i in range(len(l1)):    
    l1[i] = int(l1[i])
    massiv2 = input().split(' ')
    n2 = int(massiv2[0])
    massiv2.pop(0)

for i in range(len(massiv2)):    
    massiv2[i] = int(massiv2[i])
    l2 = input().split(' ')

for i in range(len(l2)):
    l2[i] = int(l2[i])
    l1.pop(0)
    l2.pop(0)
    l1.sort()
    l2.sort()
    money = input().split(' ')

for i in range(len(money)):
    money[i] = int(money[i])

for i in range(len(money)):    
    k = 0
    for j in range(len(l1)):        
        if money[i] >= l1[j]:
            k += 1    
            money[i] -= k

for i in range(len(money) - 1):
    money[i + 1] = money[i] * massiv1[i] + money[i + 1]
    money = [money[-1]]

for i in range(n2 - 1):
    money.append(money[i] // 
    massiv2[len(massiv2) - i - 1])    
    money[i] %= massiv2[len(massiv2) - 1 - i]
    money = money[::-1]

for i in range(len(money)):    
    k = 0
    for j in range(len(l2)):        
        if money[i] >= l2[j]:
           money[i] += 1    
           money[i] = str(money[i])

print(" ".join(money))
