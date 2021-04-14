import {Container,Row,Col} from 'react-bootstrap';
import Header from './Components/Static/Header';
import Footer from './Components/Static/Footer';
import {
  BrowserRouter as Router,
  Switch,
  Route
} from "react-router-dom";

import Home from './Components/Pages/Home';
import Services from './Components/Pages/Services';
import AboutUs from './Components/Pages/AboutUs';


function App() {
  return (
    <Router>
    <Container fluid>
    <Row>
      <Col>
        <Header>
        </Header>
      </Col>
    </Row>
    <Row>
    <Switch>
         
          <Route path="/services">
            <Services />
          </Route>
          <Route path="/aboutus">
            <AboutUs />
          </Route>
          <Route path="/">
            <Home />
          </Route>
        </Switch>
    </Row>
    <Row>
    <Col>
       <Footer>

       </Footer>
      </Col>
    </Row>
  </Container>
  </Router>
  );
}

export default App;
