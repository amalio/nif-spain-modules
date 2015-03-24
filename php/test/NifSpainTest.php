<?php
require_once("../src/NifSpain.php");

class NifSpainTest extends PHPUnit_Framework_TestCase {

    private $nifSpain;

    protected function setUp()
    {
        $this->nifSpain = new NifSpain();
    }

    protected function tearDown()
    {
       $this->nifSpain = null;
    }

    public function testGetLetter()
    {
        $this->assertEquals("B", $this->nifSpain->getLetter(12332358));
        $this->assertEquals("L", $this->nifSpain->getLetter(12311919));
        $this->assertNotEquals("L", $this->nifSpain->getLetter(12311911));
        $this->assertEquals("B", $this->nifSpain->getLetter("12332358"));

    }

    public function testCheck()
    {
        $this->assertTrue($this->nifSpain->check("12332358B"));
        $this->assertTrue($this->nifSpain->check("12311919L"));
        $this->assertFalse($this->nifSpain->check("12311911L"));
        $this->assertFalse($this->nifSpain->check("12"));
        $this->assertFalse($this->nifSpain->check(12));
    }

}
