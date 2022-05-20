import React, { Component } from 'react';

export class FetchContainers extends Component {
  static displayName = FetchContainers.name;

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 1
    });
  }

  render() {
    return (
      <div>
        <h1>Containers</h1>

        <p>Coming soon.</p>

      </div>
    );
  }
}
