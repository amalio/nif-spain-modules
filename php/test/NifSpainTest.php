<?php
require_once("../src/NifSpain.php");

class NifSpainTest extends PHPUnit_Framework_TestCase {

    public function testGetLetter()
    {
        $nifSpain = new NifSpain();

        $this->assertEquals("B", $nifSpain->getLetter(12332358));
    }

}
