import React from 'react';
import './presidents.css'
import axios from 'axios';
import PresidentComponent from './presdent/president';
import whiteHouseLogo from '../../assets/images/white_house_logo.png';

export default class PresidentsComponent extends React.Component {

    constructor() {
        super();

        this.state = { data: [] }

        let axiosConfig = {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                "Access-Control-Allow-Origin": "*",
            }
        };

        axios.get(`https://picamera162.azurewebsites.net/api/presidents`, axiosConfig)
        .then(res => {
            this.setState({
                data: res.data.data
            });
        });
    }
    
    render() {
        return (
            <>
                <div className="landing-page">
                    <div className="container">
                        <div className="row">
                            <img 
                                className="img-fluid mx-auto"
                                alt="president list"
                                src={whiteHouseLogo}
                            />
                        </div>
                        <div className="row">
                            <hr className="header-line col-md-6 col-10 mt-0"/>
                        </div>
                        <div className="row text-white text-center">
                            <h1 className="col-md-12 pt-0 title">PRESIDENTS LIST</h1>
                        </div>
                        {this.state.data.map((president, i) => {
                            return (
                                <div className="row justify-content-md-center" key={i}>
                                    <div className="col-md-10 col-lg-7" key={i}>
                                        <PresidentComponent data={president} key={i}></PresidentComponent>
                                    </div>
                                </div>
                            );
                        })}
                        <br/>
                    </div>                
                </div>
            </>
        );
    }
}