import React from 'react'
import {Navbar,Nav,NavDropdown,Jumbotron,Container,Row,Col} from 'react-bootstrap';
import HeaderImage from '../../Images/Static/Header.jpeg'; // with import

export default function Header() {
    
    const JumboTronStyle = {
        backgroundImage: "url('"+HeaderImage+"')",
        minHeight:"60vh",
        
      };

    return (
        <Container fluid>
            <Row>
            <Col>
        <Navbar collapseOnSelect expand="lg" sticky="top" >
            <Navbar.Brand href="/">MS Infoware</Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />
            <Navbar.Collapse id="responsive-navbar-nav">
                <Nav className="mr-auto">
                <Nav.Link href="/">Home</Nav.Link>
                <Nav.Link href="/Services">Services</Nav.Link>
                <Nav.Link href="/AboutUs">About Us</Nav.Link>
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
<Jumbotron style={JumboTronStyle} >

 
</Jumbotron>
</Col>
<Col sm="1"></Col>
</Row>
</Container>
    )
}
