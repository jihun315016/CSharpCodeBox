// 1350 진짜 공간

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class acmicpc_1350 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        List<Long> list = new ArrayList<>();
        long c, total = 0;

        long k;
        for (int i = 0; i < n; i++) {
            k = sc.nextInt();
            list.add(k);
        }

        c = sc.nextInt();

        for (int i = 0; i < list.size(); i++) {
            total = total + (int)Math.ceil((double)list.get(i) / c) * c;
        }

        System.out.println(total);
    }
}
