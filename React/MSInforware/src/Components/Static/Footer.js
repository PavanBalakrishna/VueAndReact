import React from 'react';
import {Navbar,Nav,} from 'react-bootstrap';

export default function Footer() {
    return (
      <Navbar sticky='bottom'>
          <Nav>
            <Nav.Link>©2021 by MS Infoware.</Nav.Link>
          </Nav>
      </Navbar>
    )
}
