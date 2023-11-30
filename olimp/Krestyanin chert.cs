Max = int(input())
total = 0
for j in range(1, Max + 1):
    for i in range(2, 18):
        if j % (2 ** i - 1) == 0:
            total += 1
res = Max + total
print(res)
