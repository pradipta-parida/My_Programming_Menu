public class UnaryDemo {

    public static void main(String[] args) {
        
        int result = +1;
        // unary operator
        // result is now 1 (i.e; whatever the number maybe, just make it positive)
        System.out.println(result);

        result--;
        // result is now 0 (i.e; whatever the number maybe, just decrement by 1 )
        System.out.println(result);

        result++;
        // result is now 1 (i.e; whatever the number maybe, just increment by 1 )
        System.out.println(result);

        result = -result;
        // unary operator
        // result is now -1 (i.e; whatever the number maybe, just make it neagtive)
        System.out.println(result);

        boolean success = false;
        // false
        System.out.println(success);
        // true
        System.out.println(!success); // ! will flip/invert the boolean value





    }
    
}
