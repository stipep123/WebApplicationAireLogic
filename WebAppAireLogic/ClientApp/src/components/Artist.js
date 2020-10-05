import React, { Component } from 'react';
import axios from 'axios';

export class Artist extends Component {
    static displayName = Artist.name;


    constructor(props) {
        super(props);
        this.state = { artist: [], loading: true };
        this.HandleClick = this.HandleClick.bind(this);
    }

    HandleClick(e) {
        this.props.history.push("/");
    }


    loadData() {
        axios.get('https://localhost:44311/artist/' + this.props.location.state.artist)
            .then((response) => {
                this.setState({ artist: response.data, loading: false });
                console.log(this.state.artist);
            });
    }

 
    componentDidMount() {

        this.loadData();
    }

    static renderArtist(artistobject, artist) {
        console.log(artist);
        return (
            <div>
                <section class="div-outline">
                    <br></br>
                    <label>Artist name: </label><label>{artist.name}</label><br></br>
                    <label>Number of albums: </label><label>{artist.numberOfAlbums}</label><br></br>
                    <label>Number of songs: </label><label>{artist.numberOfSongs}</label><br></br>
                    <label>Number of average words: </label> <label>{artist.averageNumOfWords}</label><br></br>
                    <label>Number of minimum words in song: </label> <label> {artist.minimumWords}</label><br></br>
                    <label>Number of maximum words in song: </label> <label> {artist.maximumWords}</label><br></br>
                    <label>Average difference in words by album: </label> <label> {artist.changeByAlbum} </label>
                    <br></br><br></br>
                    <button onClick={artistobject.HandleClick.bind(this)} type="button" class="btn btn-primary">New Search</button>
                    <br></br><br></br>
                 </section>            
            </div>
        );
    }


    render() {
        var artistobject = this;
        let contents = this.state.loading
            ? <div class="loader"> </div>
            : Artist.renderArtist(artistobject, this.state.artist);
        return (
            <div>
                <h1 class="header-text">ARTIST INFO</h1>
                {contents}
                <br></br>
            </div>
        );
    }
}