import React from 'react';
import './presidents.css'
import PresidentComponent from './presdent/president';
import whiteHouseLogo from '../../assets/images/white_house_logo.png';

export default class PresidentsComponent extends React.Component {

    constructor() {
        super();
        this.presidents = [
            {
                name: "George Washington",
                birthday: "1732-02-22T00:00:00",
                birthplace: "Westmoreland Co., Va.",
                deathDay: "1799-12-14T00:00:00",
                deathPlace: "Mount Vernon, Va.",
                urlMoreInfo: "https://www.google.com",
                urlPlaceInfo: "https://www.avianca.com",
                urlImage: "https://presidenstory.com/usimag/phot2/washington.jpg",
                id: 0,
                idCreateUser: 0,
                createDate: null
            },
            {
                name: "Juan Espinosa",
                birthday: "1732-02-22T00:00:00",
                birthplace: "Westmoreland Co., Va.",
                deathDay: "1799-12-14T00:00:00",
                deathPlace: "Mount Vernon, Va.",
                urlMoreInfo: "https://www.google.com",
                urlPlaceInfo: "https://www.avianca.com",
                id: 0,
                idCreateUser: 0,
                createDate: null
            }
        ];
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
                        {this.presidents.map(president => {
                            return (
                                <div className="row justify-content-md-center">
                                    <div className="col-md-10 col-lg-7">
                                        <PresidentComponent data={president}></PresidentComponent>
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