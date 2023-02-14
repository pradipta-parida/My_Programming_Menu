class Car {
    String color;
    String type; // SUV; Hatchback

    public void ride() { // A simple Method or Function
        System.out.println("Riding Something");
    }

    public void printColor() {

    }
}

public class OOPS // Main Class
{
    public static void main(String[] args) { // Main function comes under Main Class(that takes string arguments)
        Car car1 = new Car();
        car1.color = "blue"; // To access the properties of the car
        car1.type = "SUV";
        car1.ride();
    }
}
