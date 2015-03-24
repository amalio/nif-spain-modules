<?php


class NifSpain {

    private $correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";

    public function getLetter($numbers)
    {
        return $this->correspondencia[$numbers % 23];
    }

    public function check($nif)
    {
        if (strlen($nif) != 9)
            return false;
        else
        {
            $valid_letter = $this->getLetter(substr($nif,0,9));

            return $valid_letter == substr($nif,8,9);

        }
    }
}