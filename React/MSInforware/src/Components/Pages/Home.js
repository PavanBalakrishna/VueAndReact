import React from 'react'
import {Image,Container,Col,Row} from 'react-bootstrap';
import Section1Image from '../../Images/Home/Section1.jpeg';
import Section2Image from '../../Images/Home/Section2.jpeg';
import Section3Image from '../../Images/Home/Section3.jpeg';

export default function Home() {
    return (
        <>
        <div className='home-container'>
        <h3>MS Infoware Services</h3>
        <center className="center-align">
        Backed by a team of experienced professionals, our strategic services meet the needs of all types and sizes of clients - from small startups to large firms - and deliver lasting changes with measurable growth. Please get in touch with us today to learn how MS Infoware can help your future success.
        </center>
    </div>
        <Container fluid className='home-sections'>
            <Row>
                <Col md='1' sm='1'></Col>
                <Col md='6' sm='10'>
                    <Image src={Section1Image} ></Image>
                </Col>
                <Col md='4' sm='10' className='home-section-content' >
                    <h3>
                    Industrial Automation
                    </h3>
                    <p>
                    With years of experience, our staff has the capabilities and expertise to take your business to the next level. At MS Infoware, we combine our insights and skills to transform your processes and strategies, and in turn, your company. We’re proud to help shape and improve how our clients structure and manage their business.
                    </p>
                </Col>
                <Col md='1' sm='1'></Col>
            </Row>
            <Row>
                <Col md='1' sm='1'></Col>
                <Col md='6' sm='10' className='home-service-desktop-right'>
                    <Image src={Section2Image} ></Image>
                </Col>
                <Col md='4' sm='10' className='home-service-desktop-left home-section-content' >
                    <h3>
                    Professional Services
                    </h3>
                    <p>
                    Looking to develop your business but not sure where to turn? Need help planning or executing your next project? Let us guide you. Any organization can move forward with small incremental changes, but building for the future in today’s rapidly evolving environment means taking bold chances and making insightful decisions.
                    </p>
                </Col>
                <Col md='1' sm='1'></Col>
                
            </Row>
            <Row>
                <Col md='1' sm='1'></Col>
                <Col md='6' sm='10'>
                    <Image src={Section3Image} ></Image>
                </Col>
                <Col md='4' sm='10' className='home-section-content'>
                    <h3>
                    Mechanical Design Services
                    </h3>
                    <p>
                    We examine what organizations are doing to stay relevant and competitive in this fast-paced world, and which ones are doing it best. We then strategize using smart tools and global resources in order to understand the implications of every choice our clients can make. Get in touch to learn more about how this service can help you.
                    </p>
                </Col>
                <Col md='1' sm='1'></Col>
            </Row>
        </Container>
        </>
    )
}
