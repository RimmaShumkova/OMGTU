n = int(input())

def k(n):
if n < 3:
return 0

elif n == 3:
return 1

elif n % 2 == 1:
return k(n // 2) + k(n // 2 + 1)

else:
return 2*k(n // 2)

print(k(n))
