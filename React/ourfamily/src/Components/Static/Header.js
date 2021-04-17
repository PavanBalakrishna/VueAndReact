import React from 'react'
import {Navbar,Nav,Image} from 'react-bootstrap';

import {Link}  from "react-router-dom";
import logo from '../../Images/Logo.png';

export default function Header() {
  

    return (

        <Navbar collapseOnSelect expand="lg" sticky="top" >
            <Navbar.Brand href="/"><Image src={logo}></Image></Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />
            <Navbar.Collapse id="responsive-navbar-nav">
                <Nav className="mr-auto">
                <Nav.Link as={Link} to="/">Home</Nav.Link>
                <Nav.Link as={Link} to="/Poems">Poems</Nav.Link>
                <Nav.Link as={Link} to="/AboutUs">About Us</Nav.Link>
                </Nav>
              
            </Navbar.Collapse>
</Navbar>

    )
}
