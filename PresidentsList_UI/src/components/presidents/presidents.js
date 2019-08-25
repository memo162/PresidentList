import React from 'react';
import './presidents.css'
import whiteHouseLogo from '../../assets/images/white_house_logo.png';

export default class PresidentsComponent extends React.Component {
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
                            <hr className="header-line col-md-6"/>
                        </div>
                        <div className="row text-white text-center">
                            <h1 className="col-md-12 pt-3 title">PRESIDENTS LIST</h1>
                        </div>   
                    </div>                     
                </div>
            </>
        );
    }
}