# High Availablity / Resilient

Ways that high availabilty can be ensured are:

- minimising single points of failure
  - IE having multiple instances of services either running or warmed up ready to be invoked (fan out fan in)
- when deploying any new features utilising techniques like Blue/Green deployment
- regular backups
- data being copied across multiple locations when created
  - This has the added benefit of being able to get the data quicker as it may end up being copied to a data centre closer to the user
- identify where a key failure is likely to happen and investigate ways to reduce this. (de composing into multiple parts, more server resources allocated etc)
- Utilise Cloud Providers and not on-premises services. Cloud Providers provide a lot of redunancy and availabilty options.

# Threat mitigation

Ways to mitigate any abuse of the end points by utilisation of automated tools (such as ones used for dos attacks) would be some form of request throttling. One such technique is the Leaky Bucket method. Most Cloud providers offer request throttling as part of an API Gateway/Management.
