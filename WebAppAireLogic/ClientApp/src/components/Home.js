import React, { Component } from 'react';


export class Home extends Component {
    static displayName = Home.name;


    onClick() {
        this.props.history.push({
            pathname: '/Artist',
            state: { artist : document.getElementById("artist").value }
        })
    }

    render() {
        return (
            <div>
                <h1 class = "header-text">AIRE LOGIC</h1>
                <div class="div-outline">
                    <br></br>
                    <label>Please enter name and surname of artist:</label>
                    <br></br><br></br>
                    <input type = "text" id = "artist" placeholder = "Jimmy Hendrix"/>
                    <br></br><br></br>
                    <button onClick={this.onClick.bind(this)} type="button" class="btn btn-primary">Find</button>
                    <br></br><br></br>
                </div>
            </div>
        );
    }
}