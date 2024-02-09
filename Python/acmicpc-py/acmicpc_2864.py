# 2864 5와 6의 차이

a, b = input().split()

sMin = int(a.replace('6', '5')) + int(b.replace('6', '5'))
sMax = int(a.replace('5', '6')) + int(b.replace('5', '6'))

print(sMin, sMax)

