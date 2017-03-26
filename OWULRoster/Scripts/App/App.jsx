var App = React.createClass({
    getInitialState: function () {
        return { teams: [] };
    },

    componentDidMount: function () {
        this.getTeams();
    },

    getTeams: function () {
        $.ajax({
            url: "/Teams",
            dataType: 'json',
            success: function (data) {
                console.log("Below is in app")
                console.log(data.teams);
                console.log("Above is in app")
                this.setState({ teams: data.teams });
            }.bind(this),
            error: function (xhr, status, err) {
                console.error(this.props.url, status, err.toString());
            }.bind(this)
        });
    },

    render: function () {
        return (
            <section id="App">
                The app loaded
                <ul>
                    <Teams teams={this.state.teams}></Teams>
                </ul>
            </section>
        );
    }
});

ReactDOM.render(<App />, document.getElementById('app'));
