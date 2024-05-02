# 1076 저항

import sys
input = sys.stdin.readline

dic = {
    "black" : 0,
    "brown" : 1,
    "red" : 2,
    "orange" : 3,
    "yellow" : 4,
    "green" : 5,
    "blue" : 6,
    "violet" : 7,
    "grey" : 8,
    "white" : 9
}

a = input().rstrip()
b = input().rstrip()
c = input().rstrip()

print((dic[a] * 10 + dic[b]) * 10 ** dic[c])
