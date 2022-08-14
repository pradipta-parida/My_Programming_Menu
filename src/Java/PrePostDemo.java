public class PrePostDemo {
    public static void main(String[] args) {
        
        int i=3;

        System.out.println(++i);
        System.out.println(i);

        // prints 4
        // value of i is assigned first and incremented later
        System.out.println(i++);
        System.out.println(i);

        ++i;
        // prints 5
        // value of i is incremented first and assigned later
        System.out.println(i);

        // prints 6
        System.out.println(++i);

        // prints 6
        // since, its a post-incremented the assigned value is printed not the incremented
        System.out.println(i++);

        System.out.println(i);

        int j=3;
        System.out.println(++j + j++ + ++j);
        //4+4+6=14
        System.out.println(j);
        //6

        int k =3;
        System.out.println(++k + ++k + ++k);
        //4+5+6=15
        System.out.println(k);
        //6
        
        int l =3;
        System.out.println(l++ + l++ + l++);
        //3+4+5=12
        System.out.println(l);
        //6

        int a=12;
        System.out.println(++a);//13
        System.out.println(a);//13

        int b=13;
        System.out.println(b++);//13
        System.out.println(b);//14
    }
}