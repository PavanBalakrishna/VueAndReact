import React from 'react'
import {Navbar,Nav,Jumbotron,Container,Row,Col} from 'react-bootstrap';

import {Link}  from "react-router-dom";

export default function Header() {
  

    return (
        <Container fluid>
            <Row>
            <Col>
        <Navbar collapseOnSelect expand="lg" sticky="top" >
            <Navbar.Brand href="/">MS Infoware</Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />
            <Navbar.Collapse id="responsive-navbar-nav">
                <Nav className="mr-auto">
                <Nav.Link as={Link} to="/">Home</Nav.Link>
                <Nav.Link as={Link} to="/Services">Services</Nav.Link>
                <Nav.Link as={Link} to="/AboutUs">About Us</Nav.Link>
                {/* <NavDropdown title="Dropdown" id="collasible-nav-dropdown">
                    <NavDropdown.Item href="#action/3.1">Action</NavDropdown.Item>
                    <NavDropdown.Item href="#action/3.2">Another action</NavDropdown.Item>
                    <NavDropdown.Item href="#action/3.3">Something</NavDropdown.Item>
                    <NavDropdown.Divider />
                    <NavDropdown.Item href="#action/3.4">Separated link</NavDropdown.Item>
                </NavDropdown> */}
                </Nav>
              
            </Navbar.Collapse>
</Navbar>
</Col>
</Row>
<Row>
    <Col sm="1"></Col>
    <Col sm="10">
<Jumbotron className='header-jumbotron' >

 
</Jumbotron>
</Col>
<Col sm="1"></Col>
</Row>
</Container>
    )
}
