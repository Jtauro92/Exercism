class Greeter {
    public static void main(String[] args) {
        System.out.println(new Greeter().getGreeting());
    }

    String getGreeting() {
        return "Hello, World!";
    }

}
