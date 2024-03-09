N = int(input())
Details = []
for i in range(0, N):
    Details.append([int(W) for W in input().split()])

details = []
for i in range(0, N):
    B = Details[i]
    details.append([B[0:5] , B[5:10], B[10:15], B[15:20]])

Forms = []
for i in range(0, N*2):
    Forms.append([int(W) for W in input().split()])

forms = []
for i in range(0, N*2):
    B = Forms[i]
    forms.append([B[0:5] , B[5:10], B[10:15]])


def match(forma1, forma2, detail):
    if (detail[0] == forma1[0] == forma2[2]):
        if (detail[1] == forma2[1]):
            if (detail[2] == forma2[0] == forma1[2]):
                if (detail[3] == forma1[1]):
                    return True

    if (detail[0] == forma1[0] == forma2[0][::-1]):
        if (detail[1] == forma2[1][::-1]):
            if (detail[2] == forma2[2][::-1] == forma1[2]):
                if (detail[3] == forma1[1]):
                    return True
    return False


def F(detail):
    return [detail[3], detail[0], detail[1], detail[2]]


def Ovver(detail):
    return [detail[0][::-1], detail[3][::-1], detail[2][::-1], detail[1][::-1]]


array = []
for DI in range(0, len(details)):
    d = details[DI]
    for r in range(0, 5):
        for f1_i in range(0, len(forms)):
            for f2_i in range(0, len(forms)):
                if f2_i != f1_i:
                    if match(forms[f1_i], forms[f2_i], d):
                        array.append([f1_i, f2_i])
        if r == 2:
            d = F(d)
            d = Ovver(d)
        else:
            d = F(d)

index_m = [3]
while True:
    index_m = []
    for Q in array:
        index = 0
        for ap in array:
            if Q[0] in ap:
                index += 1
            if Q[1] in ap:
                index += 1
        index_m.append(index)
    if max(index_m) == 2:
        break
    array.pop(index_m.index(max(index_m)))

for Q in array:
    Q.sort()
    print(Q[0]+1, Q[1]+1)
