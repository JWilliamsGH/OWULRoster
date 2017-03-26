var Teams = React.createClass({
    render: function () {
        let teams;
        if (this.props.teams)
        {
            console.log("Below is in teams")
            console.log(this.props.teams);
            console.log("Above is in teams")
            teams = this.props.teams.map(team => {
                console.log(team);
                return (
                    <Team key={team.TeamId} team={team} />
                );
            });
        }

        return (
            <section id="Teams">
                {teams}
            </section>
        );
    }
});