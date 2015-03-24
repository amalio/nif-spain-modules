public class NifSpain {

    public char getLetter(int numbers)
    {
        String correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        return correspondencia.charAt(numbers % 23);
    }
}
