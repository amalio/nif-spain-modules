<?php


class NifSpain {

    private $correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";

    public function getLetter($numbers)
    {
        return $this->correspondencia[$numbers % 23];
    }
}