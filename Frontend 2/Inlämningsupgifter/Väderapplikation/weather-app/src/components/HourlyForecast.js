import React, { Component } from "react";
import moment from "moment";
import "moment-timezone";
import "moment/locale/sv";
import "../css/weather-icons.min.css";

export default class HourlyForecast extends Component {
  render() {
    let styles = {
      hourlyLayout: {
        width: "25%",
        background: "rgba(255, 255, 255, .2)",
        display: "flex",
        borderRadius: "1.5em",
        justifyContent: "space-evenly",
        margin: "0 2em 2em 2em",
        minHeight: "10em"
      },
      tempLayout: {
        marginRight: "0.1em",
        fontSize: "1.2em",
        marginLeft: ".1em"
      },
      hourLayout: {
        display: "flex",
        flexDirection: "column",
        justifyContent: "space-evenly",
        alignItems: "center",
        marginRight: ".1em"
      }
    };

    let hourlyForecast = this.props.hourlyForecast
      .slice(0, 5)
      .map((item, i) => {
        let iconString = "wi wi-owm-" + item.weather[0].id;
        return (
          <div key={i} style={styles.hourLayout}>
            <div>
              {moment
                .unix(item.dt)
                .utc()
                .format("HH:mm")}
            </div>
            <i className={iconString} />
            <div key={i} style={{ fontSize: "1.2rem" }}>
              {Math.ceil(item.main.temp)}
              <i className="wi wi-degrees" style={styles.tempLayout} />
            </div>
          </div>
        );
      });
    return <div style={styles.hourlyLayout}>{hourlyForecast}</div>;
  }
}
