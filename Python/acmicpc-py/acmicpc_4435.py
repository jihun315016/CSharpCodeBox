# 4435 중간계 전쟁

gandalf = [1, 2, 3, 3, 4, 10]
dwarf = [1, 2, 2, 2, 3, 5, 10]

t = int(input())

for i in range(t):
    gArr = list(map(int, input().split()))
    dArr = list(map(int, input().split()))

    gTotal = sum([gArr[j] * gandalf[j] for j in range(len(gandalf))])
    dTotal = sum([dArr[j] * dwarf[j] for j in range(len(dwarf))])
    
    if gTotal > dTotal:
        print("Battle %d: Good triumphs over Evil" % (i + 1))
    elif gTotal == dTotal:
        print("Battle %d: No victor on this battle field" % (i + 1))
    else:
        print("Battle %d: Evil eradicates all trace of Good" % (i + 1))