from icalendar import Calendar, Event, Alarm
from datetime import datetime, timedelta
import pytz
import re

# Function to parse the text and extract events
def parse_calendar_text(text):
    event_regex = r"(\d{2})\n(.*?)\n\((\d{2}:\d{2})\)"
    matches = re.findall(event_regex, text, re.DOTALL)
    events = []
    for match in matches:
        day, event_name, time = match
        event_datetime = datetime(2023, 11, int(day), int(time[:2]), int(time[3:]), 0, tzinfo=pytz.timezone('America/New_York'))
        event_datetime_stockholm = event_datetime.astimezone(pytz.timezone('Europe/Stockholm'))
        events.append({"name": event_name.strip(), "datetime": event_datetime_stockholm})
    return events

# Function to create an iCalendar file with events
def create_ics_file(events, filename='economic_events.ics'):
    cal = Calendar()
    for event_info in events:
        event = Event()
        event.add('summary', event_info['name'])
        event.add('dtstart', event_info['datetime'])
        event.add('dtend', event_info['datetime'] + timedelta(hours=1))  # Assuming 1 hour duration
        # Adding an alarm for two days before the event
        alarm = Alarm()
        alarm.add("action", "DISPLAY")
        alarm.add('description', "Reminder: " + event_info['name'])
        alarm.add("trigger", timedelta(days=-2))
        event.add_component(alarm)
        cal.add_component(event)
    with open(filename, 'wb') as f:
        f.write(cal.to_ical())
    return filename

# Parse the text and create the iCalendar file
parsed_events = parse_calendar_text(extracted_text_new)
ics_filename = create_ics_file(parsed_events)

print(f"iCalendar file created: {ics_filename}")

