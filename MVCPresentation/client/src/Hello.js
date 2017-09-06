import React from 'react';
import request from 'superagent'

export default class Hello extends React.Component {
  state = { hello: '', movie: {title: '', gender: '', id: ''} }

  handleClick = event => {
    event.preventDefault();
    request
      .get("/controller/hello")
      .end((err, res) => {
        this.setState({ hello: res.text });
      });
  }

  handleSecondClick = event => {
    event.preventDefault();
    request
      .get("/getbyid/6")
      .end((err, res) => {
        this.setState({ movie: {...res.body} });
      });
  }

  render() {
    return (
      <div>
        <h3>Hello MVC</h3>
        <h5>request to /controller/hello</h5>
        <button onClick={this.handleClick}>Click Me</button>
        <h4>{this.state.hello}</h4>
        <h5>request to /getbyid/6</h5>
        <button onClick={this.handleSecondClick}>Click Me</button>
        <h4>Title: {this.state.movie.title}</h4>
        <h4>Gender: {this.state.movie.gender}</h4>
        <h4>Id: {this.state.movie.id}</h4>
      </div>
    )
  }
}
