import React from 'react';
import { FaBirthdayCake, FaCross, FaMapMarkerAlt } from 'react-icons/fa';
import './president.css'
import userDefaultImage from '../../../assets/images/user_default.png'

export default class PresidentComponent extends React.Component {
    render() {
        return (
            <>
                <div className="card mx-auto mb-2">
                    <div className="card-body p-2 pl-4">
                        <div className="row">
                            <div className="col-md-2 col-2 pl-1 pl-md-2 pl-lg-3">
                                <a href={this.props.data.urlMoreInfo} 
                                className="mx-auto">
                                    <img alt="PRESIDENT NAME" 
                                    className="img-fluid rounded-circle president-image"
                                    src={this.props.data.urlImage != null ? this.props.data.urlImage : userDefaultImage}/>
                                </a>
                            </div>
                            <div className="col-md-9 col-10">
                                    <a href={this.props.data.urlMoreInfo} 
                                    className="text-dark" alt="PRESIDENT NAME">
                                        <h3 className="mb-0 name-small">{
                                            this.props.data.name}
                                        </h3>
                                    </a>
                                <div>
                                    <small>
                                        <div className="row">
                                            <div title="birthday" className="col-sm-4 col-lg-3 col-5 pr-0 pr-sm-auto">
                                                <FaBirthdayCake className="mr-1"/>
                                                <span>{this.props.data.birthday.split('T')[0]}</span>
                                            </div>
                                            <div className="col-sm-8 col-lg-9 col-7 px-0 px-sm-auto">
                                                <FaMapMarkerAlt className="mr-1 text-danger"/>
                                                <span>{this.props.data.birthplace}</span>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div title="death day" className="col-sm-4 col-lg-3 col-5 pr-0 pr-sm-auto">
                                                <FaCross className="mr-1"/>
                                                <span>{this.props.data.deathDay.split('T')[0]}</span>
                                            </div>
                                            <div className="col-sm-8 col-lg-9 col-7 px-0 px-sm-auto">
                                                <FaMapMarkerAlt className="mr-1 text-danger"/>
                                                <span>{this.props.data.deathPlace}</span>
                                            </div>
                                        </div>
                                    </small>
                                </div>
                            </div>
                        </div>     
                    </div>
                </div>
            </>
        );
    }
}