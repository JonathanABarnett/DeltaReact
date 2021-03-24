import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";

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
      <ul>
        {attendees.map((attendee: any) => (
          <li key={attendee.id}>
            {attendee.FirstName} {attendee.LastName}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
