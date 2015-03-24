<?php


class NifSpain {


    public function getLetter($numbers)
    {
        $correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        return $correspondencia[$numbers % 23];
    }

    public function check($nif)
    {
        if (strlen($nif) != 9)
            return false;
        else
        {
            return $this->getLetter(substr($nif,0,9)) == substr($nif,8,9);
        }
    }
}