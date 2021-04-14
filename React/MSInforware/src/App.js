import {Container,Row,Col} from 'react-bootstrap';
import Header from './Components/Static/Header';
import Footer from './Components/Static/Footer';


function App() {
  return (
    <Container fluid>
    <Row>
      <Col>
        <Header>
        </Header>
      </Col>
    </Row>
    <Row>
    <Col>
       <Footer>
         
       </Footer>
      </Col>
    </Row>
  </Container>
  );
}

export default App;
