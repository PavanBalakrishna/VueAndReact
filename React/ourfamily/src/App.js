import {
  BrowserRouter as Router,
  Switch,
  Route
} from "react-router-dom";
import {Container,Col,Row} from 'react-bootstrap';

import Header from './Components/Static/Header';
import Home from './Components/Home';

function App() {
  return (
    <Container fluid>
       <Router>
      <Row>
        <Col>
        <Header/>
        </Col>
      </Row>
      <Row>

      </Row>
   
      <Switch>
         <Route path="/">
           <Home />
         </Route>
       </Switch>
   </Router>
   </Container>
  );
}

export default App;
