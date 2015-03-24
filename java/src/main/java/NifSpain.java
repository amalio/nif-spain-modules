public class NifSpain {

    public char getLetter(int numbers)
    {
        String correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        return correspondencia.charAt(numbers % 23);
    }

    public char getLetter(String numbersString)
    {
        return getLetter(Integer.parseInt(numbersString));

    }

    public boolean check(String nif)
    {
        if (nif.length() != 9)
            return false;
        else
        {
            return getLetter(nif.substring(0,8)) == nif.charAt(8);
        }
    }
}
