import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { Header, List } from "semantic-ui-react";

function App() {
  const [attendees, setAttendees] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/attendees").then((response) => {
      console.log(response);
      setAttendees(response.data);
    });
  }, []);

  return (
    <div className="app">
      <Header as="h2" icon="users" content="Delta React" />
      <List>
        {attendees.map((attendee: any) => (
          <List.Item key={attendee.id}>
            {attendee.firstName} {attendee.lastName}
          </List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
