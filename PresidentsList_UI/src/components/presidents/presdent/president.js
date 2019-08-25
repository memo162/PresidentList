import React from 'react';
import { FaBirthdayCake, FaCross, FaMapMarkerAlt } from 'react-icons/fa';
import './president.css'

export default class PresidentComponent extends React.Component {
    render() {
        return (
            <>
                <div className="card mx-auto">
                    <div className="card-body p-2 pl-4">
                        <div className="row">
                            <div className="col-md-2 col-2 pl-1 pl-md-2 pl-lg-3">
                                <a href="#" className="mx-auto">
                                    <img alt="PRESIDENT NAME" className="img-fluid rounded-circle president-image"
                                    src="https://presidenstory.com/usimag/phot2/washington.jpg"/>
                                </a>
                            </div>
                            <div className="col-md-9 col-10">
                                    <a href="#" className="text-dark" alt="PRESIDENT NAME">
                                        <h3 className="mb-0 name-small">George Washington</h3>
                                    </a>
                                <div>
                                    <small>
                                        <div className="row">
                                            <div className="col-sm-4 col-lg-3 col-5 pr-0 pr-sm-auto">
                                                <FaBirthdayCake className="mr-1"/>
                                                <span>1732-2-22</span>
                                            </div>
                                            <div className="col-sm-8 col-lg-9 col-7 px-0 px-sm-auto">
                                                <FaMapMarkerAlt className="mr-1 text-danger"/>
                                                <span>Westmoreland Co., Va.</span>
                                            </div>
                                        </div>
                                        <div className="row">
                                            <div className="col-sm-4 col-lg-3 col-5 pr-0 pr-sm-auto">
                                                <FaCross className="mr-1"/>
                                                <span>1799-12-14</span>
                                            </div>
                                            <div className="col-sm-8 col-lg-9 col-7 px-0 px-sm-auto">
                                                <FaMapMarkerAlt className="mr-1 text-danger"/>
                                                <span>Mount Vernon, Va.</span>
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